using CrimeSiteInvestigation.Model.Entity;
using System;
using System.Collections.Generic;

namespace CrimeSiteInvestigation.Model
{
    public class SuspeitoModel
    {
        public IEnumerable<Suspeito> GetAll()
        {
            return new Suspeito[] {
                new Suspeito { Id = 1, Nome = "Esqueleto", Image="http://www.mediacatonline.com/wp-content/uploads/2017/09/iskeletor-he-man.jpg" },
                new Suspeito { Id = 2, Nome = "Khan", Image="https://nerdist.com/wp-content/uploads/2017/01/Khan-970x538.jpg" },
                new Suspeito { Id = 3, Nome = "Darth vader", Image="https://jovemnerd.com.br/wp-content/uploads/2017/05/v-star-wars-day-darth-vader-fantasia-policia-760x428.jpg" },
                new Suspeito { Id = 4, Nome = "Slidehow Bob", Image="https://vignette.wikia.nocookie.net/villains/images/9/91/Hello-Bart-sideshow-bob-30616697-384-288.jpg" },
                new Suspeito { Id = 5, Nome = "Coringa", Image="https://i0.wp.com/www.fatosdesconhecidos.com.br/wp-content/uploads/2015/07/coringa.jpg" },
                new Suspeito { Id = 6, Nome = "Duende Verde", Image="https://s.aficionados.com.br/imagens/duende-verde-retorna-com-visual-monstruoso-nos-quadrinhos_f.jpg" }};

        }
    }
}
