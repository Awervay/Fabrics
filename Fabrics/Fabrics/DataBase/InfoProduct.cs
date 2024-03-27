//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fabrics.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Media.Imaging;

    public partial class InfoProduct
    {
        public int ID_Product { get; set; }
        public string Name { get; set; }
        public string DescriptionProduct { get; set; }
        public string Manufacture { get; set; }
        public int Cost { get; set; }
        public int QuantityStock { get; set; }
        public string Photo { get; set; }

        public BitmapImage Image
        {
            get
            {
                if (Photo.Contains(@"\"))
                {
                    return new BitmapImage(new Uri(Environment.CurrentDirectory + Photo));
                }
                else
                {
                    return new BitmapImage(new Uri(Environment.CurrentDirectory + @"\Resource\picture.png"));
                }
            }
        }
    }
}
