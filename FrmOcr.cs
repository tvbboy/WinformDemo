using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing; // Ensure this namespace is included for Bitmap conversion
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
namespace myproject
{
    public partial class FrmOcr : Form
    {
        // 车牌识别参数
        private const double MinPlateAspectRatio = 2.0;
        private const double MaxPlateAspectRatio = 5.0;
        private const int MinPlateWidth = 100;
        private const int MinPlateHeight = 30;
        public FrmOcr()
        {
            InitializeComponent();
        }

        private void FrmOcr_Load(object sender, EventArgs e)
        {

        }

     
    private void btnLoadImage_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog dlg = new OpenFileDialog())
        {
            dlg.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image =Image.FromFile(dlg.FileName); // Load the image into PictureBox
                    Mat image = CvInvoke.Imread(dlg.FileName);
                var plateImage = DetectLicensePlate(image);

                if (plateImage != null)
                {
                        //   pictureBox.Image = plateImage?.ToBitmap() ?? image.ToBitmap();
                    txtResult.Text=    RecognizePlateText(plateImage);
                    txtLog.Text = "状态: 从文件检测到车牌";
                }
                else
                {
                   // pictureBox.Image = ConvertMatToBitmap(image); // Use the conversion method
                    txtLog.Text = "状态: 未检测到车牌";
                }
            }

        }

          


        }
       
        private Mat DetectLicensePlate(Mat inputImage)
        {
            try
            {
                // 1. 转换为灰度图像
                Mat gray = new Mat();
                CvInvoke.CvtColor(inputImage, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                // 2. 高斯模糊
                CvInvoke.GaussianBlur(gray, gray, new Size(5, 5), 1);

                // 3. Sobel边缘检测
                Mat sobel = new Mat();
                CvInvoke.Sobel(gray, sobel, Emgu.CV.CvEnum.DepthType.Cv8U, 1, 0, 3);

                // 4. 阈值处理
                Mat threshold = new Mat();
                CvInvoke.Threshold(sobel, threshold, 0, 255,
                    Emgu.CV.CvEnum.ThresholdType.Binary | Emgu.CV.CvEnum.ThresholdType.Otsu);

                // 5. 形态学闭操作
                Mat morphKernel = CvInvoke.GetStructuringElement(
                    Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(17, 3), new Point(-1, -1));
                CvInvoke.MorphologyEx(threshold, threshold,
                    Emgu.CV.CvEnum.MorphOp.Close, morphKernel, new Point(-1, -1), 1,
                    Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0));

                // 6. 查找轮廓
                var contours = new VectorOfVectorOfPoint();
                var hierarchy = new Mat();
                CvInvoke.FindContours(threshold, contours, hierarchy,
                    Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                // 7. 筛选可能的车牌区域
                for (int i = 0; i < contours.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                    double aspectRatio = (double)rect.Width / rect.Height;

                    // 根据宽高比和大小筛选车牌区域
                    if (aspectRatio > MinPlateAspectRatio &&
                        aspectRatio < MaxPlateAspectRatio &&
                        rect.Width > MinPlateWidth &&
                        rect.Height > MinPlateHeight)
                    {
                        // 8. 绘制车牌区域
                        CvInvoke.Rectangle(inputImage, rect,
                            new MCvScalar(0, 255, 0), 2);

                        // 9. 提取车牌区域
                        Mat plateRegion = new Mat(inputImage, rect);

                        // 10. 显示车牌文本（实际项目中应使用OCR识别）
                        CvInvoke.PutText(inputImage, "车牌区域",
                            new Point(rect.X, rect.Y - 10),
                            Emgu.CV.CvEnum.FontFace.HersheySimplex,
                            0.8, new MCvScalar(0, 255, 0), 2);

                        return inputImage;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"车牌识别错误: {ex.Message}");
            }

            return null;
        }
        // 在DetectLicensePlate方法中添加：
        private string RecognizePlateText(Mat plateImage)
        {
            // 转换为灰度
            Mat gray = new Mat();
            CvInvoke.CvtColor(plateImage, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

            // 二值化
            Mat binary = new Mat();
            CvInvoke.Threshold(gray, binary, 0, 255,
                Emgu.CV.CvEnum.ThresholdType.Binary | Emgu.CV.CvEnum.ThresholdType.Otsu);

            // 使用Tesseract识别
            //using (var ocr = new TesseractEngine("../../../tessdata", "eng+chi_sim", EngineMode.Default))
            using (var ocr = new TesseractEngine("../../../tessdata", "eng+chi_sim", EngineMode.TesseractAndLstm))
            {
                using (var img = Pix.LoadFromMemory(binary.ToImage<Gray, byte>().ToJpegData()))
                {
                    using (var page = ocr.Process(img))
                    {
                        return page.GetText();
                    }
                }
            }
        }

    }
}
