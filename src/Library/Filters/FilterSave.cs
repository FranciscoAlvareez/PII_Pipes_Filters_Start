using System;
using System.Drawing;
using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        PictureProvider provider = new PictureProvider();
        public int numero;
        public FilterSave(int numero)
        {
            this.numero=numero;
        }
        public IPicture Filter(IPicture image)
        {
            IPicture result = image.Clone();
            provider.SavePicture(image, @$"Imagen_Editada{this.numero}.jpg");
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("team 18", @$"Imagen_Editada{this.numero}.jpg"));
            return result;
        }
    }
}