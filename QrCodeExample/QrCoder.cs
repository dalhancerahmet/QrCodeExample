using QRCoder;

namespace QrCodeExample
{
    public class QrCoder : IQrCoder
    {
        public byte[] GenerateQrCode(string value)
        {
            QRCodeGenerator qRCodeGenerator = new();
            QRCodeData data = qRCodeGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new(data);
            byte[] byteGraphic = qrCode.GetGraphic(10, new byte[] { 84, 99, 71 }, new byte[] { 240, 240, 240 });
            return byteGraphic;
        }
    }
}
