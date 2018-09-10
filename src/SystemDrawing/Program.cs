using System;
using System.Drawing.Imaging;
using Newtonsoft.Json;

namespace SystemDrawing {
    class MyData {
        public ImageFormat ImageFormat { set; get; }
        public int Value { set; get; }
    }

    class Program {
        static void Main(string[] args) {
            var json = @"{
                ""imageFormat"": 0,
                ""value"": 1000
            }
            ";

            // var obj = JsonConvert.DeserializeObject<MyData>(json);
            var data = new MyData {
                ImageFormat = ImageFormat.Bmp,
                Value = 200
            };

            var newJson = JsonConvert.SerializeObject(data);

            Console.WriteLine(newJson);

            var newObject = JsonConvert.DeserializeObject<MyData>(newJson);
            Console.WriteLine(newObject.ImageFormat == ImageFormat.Bmp);
            Console.WriteLine(newObject.ImageFormat.Equals(ImageFormat.Bmp));
            Console.WriteLine(newObject.ImageFormat);
        }
    }
}
