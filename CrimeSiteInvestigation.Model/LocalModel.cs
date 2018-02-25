using CrimeSiteInvestigation.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrimeSiteInvestigation.Model
{
    public class LocalModel
    {
        public IEnumerable<Local> GetAll()
        {
            return new Local[] {
                new Local { Id = 1, Nome = "Etérnia", Image="http://www.hemanworld.com/wp-content/uploads/2015/09/The-Legend-of-Eternia.jpg" },
                new Local { Id = 2, Nome = "Vulcano", Image="http://www.meteoweb.eu/wp-content/uploads/2012/01/vulcano-Erta-Ale-2.png" },
                new Local { Id = 3, Nome = "Tatooine", Image="https://lumiere-a.akamaihd.net/v1/images/Tatooine_36689d1b.jpeg" },
                new Local { Id = 4, Nome = "Springfield", Image="https://images.minilua.com/wp-content/uploads/2012/04/SpringfieldSimpsons.jpg" },
                new Local { Id = 5, Nome = "Gotham", Image="http://revistagalileu.globo.com/Revista/Galileu2/foto/0,,42812526,00.jpg" },
                new Local { Id = 6, Nome = "Nova York", Image="https://4.bp.blogspot.com/-AFCCfkr_egM/VGwHPieOzUI/AAAAAAAAfbo/M3KdrtoEUHw/s1600/new-york-seguro-viagem.jpg" },
                new Local { Id = 7, Nome = "Sibéria", Image="http://4.bp.blogspot.com/-E0FcvJirExQ/UfaK45Y7r6I/AAAAAAAAF0k/dTQbn4B__24/s1600/norilsk+aerial.JPG" },
                new Local { Id = 8, Nome = "Machu Picchu", Image="https://media-cdn.tripadvisor.com/media/photo-s/02/5c/5c/8a/a-voir-absolument.jpg" },
                new Local { Id = 9, Nome = "Show do Katinguele", Image="http://www.arteblitz.com/imagens/conteudos/312/getImageObj%20(2).jpg" },
                new Local { Id = 10, Nome = "São Paulo", Image="https://abrilviagemeturismo.files.wordpress.com/2016/12/sp12.jpeg?quality=70&strip=info&w=922" },};

        }
    }
}