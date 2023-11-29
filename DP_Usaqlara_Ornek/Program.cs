

//namespace Sef_Olan_Ornek //Burada sef olan budur ki sabah Xeber inter facesinden Teleqram torense alem deyecey birbirini ve bu mentiqnen code yazsaq gerey milyon edet classimiz olsunki butun ehtimallari nezere alaq
//{

//    public interface IXeber
//    {
//        public string XeberVer();
//    }

//    public class SMS : IXeber
//    {
//        public string XeberVer()
//        {
//            return "SMS Xeber Getdi";
//        }
//    }

//    public class FaceBook : IXeber
//    {
//        public string XeberVer()
//        {
//            return "FaceBook Xeber Getdi";
//        }
//    }


//    public class Instagram : IXeber
//    {
//        public string XeberVer()
//        {
//            return "Instagram Xeber Getdi";
//        }
//    }

//    public class SMS_FaceBook : IXeber
//    {
//        public string XeberVer()
//        {
//            return "SMS Xeber Getdi Ve FaceBook Xeber Getdi";
//        }
//    }

//    public class SMS_Instagram : IXeber
//    {
//        public string XeberVer()
//        {
//            return "SMS Xeber Getdi Ve Instagram Xeber Getdi";
//        }
//    }


//    public class FaceBook_Instagram : IXeber
//    {
//        public string XeberVer()
//        {
//            return "FaceBook Xeber Getdi Ve Instagram Xeber Getdi";
//        }
//    }

//    public class FaceBook_Instagram_SMS : IXeber
//    {
//        public string XeberVer()
//        {
//            return "FaceBook Xeber Getdi Ve Instagram Xeber Getdi Ve SMS Xeber Getdi";
//        }
//    }


//    public class Program
//    {

//        static void Main(string[] args)
//        {

//            IXeber xeber = new FaceBook();

//            Console.WriteLine(xeber.XeberVer());




//        }

//    }








//}


//namespace Duz_Olan_Ornek
//{

//    public interface IXeber
//    {
//        public string XeberVer();
//    }


//    public class BaslaXeber : IXeber
//    {
//        public string XeberVer()
//        {
//            return "Xeber";
//        }
//    }


//    public class DecoratorSMS : IXeber
//    {
//        private IXeber? xeber;

//        public DecoratorSMS(IXeber? xeber)
//        {
//            this.xeber = xeber;
//        }

//        public string XeberVer()
//        {
//            string cemleXeberi = xeber!.XeberVer();

//            cemleXeberi +=   " " + "SMS Xeber Getdi";

//            return cemleXeberi;
//        } 
//    }

//    public class DecoratorFaceBook : IXeber
//    {
//        private IXeber? xeber;

//        public DecoratorFaceBook(IXeber? xeber)
//        {
//            this.xeber = xeber;
//        }

//        public string XeberVer()
//        {
//            string cemleXeberi = xeber!.XeberVer();

//            cemleXeberi += " " + "FaceBook Xeber Getdi";

//            return cemleXeberi;
//        }
//    }

//    public class DecoratorInstagram : IXeber
//    {
//        private IXeber? xeber;

//        public string? DahaEtrafli { get; set; }

//        public DecoratorInstagram(IXeber? xeber)
//        {
//            this.xeber = xeber;
//        }

//        public string XeberVer()
//        {
//            string cemleXeberi = xeber!.XeberVer();

//            cemleXeberi += " " + "Instagram Xeber Getdi";

//            return cemleXeberi;
//        }

//        public void DahaEtrafliXeberVer()
//        {

//            Console.WriteLine(DahaEtrafli); // usaqlar bu misaldir ki elave xusisiyyetde vermek olur !!!
//        }


//    }



//    public class Program
//    {

//        static void Main(string[] args)
//        {


//            IXeber xeber = new BaslaXeber();
//            DecoratorSMS decoratorSMS = new DecoratorSMS(xeber);
//            DecoratorFaceBook decoratorFaceBook = new DecoratorFaceBook(decoratorSMS);

//            Console.WriteLine(decoratorFaceBook.XeberVer());

//        }



//    }






//}

