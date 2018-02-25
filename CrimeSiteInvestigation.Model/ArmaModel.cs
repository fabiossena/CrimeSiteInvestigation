using CrimeSiteInvestigation.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrimeSiteInvestigation.Model
{
    public class ArmaModel
    {
        public IEnumerable<Arma> GetAll() {
            return new Arma[] {
                new Arma { Id = 1, Nome = "Cajado Devastador", Image="https://www.allcenter.com.br/wp-content/uploads/2017/05/MOTU-Skeletor-statue-Sideshow-Classe-Nerd-F-011.jpg" },
                new Arma { Id = 2, Nome = "Phaser", Image="http://www.tk560.com/herophaser.jpg" },
                new Arma { Id = 3, Nome = "Peixeira", Image="http://www.paraibaurgente.com.br/wp-content/uploads/2017/01/fac%C3%A3o-1-448x280.jpg" },
                new Arma { Id = 4, Nome = "Trezoitão", Image="https://blogdovladimir.files.wordpress.com/2010/08/tiro1.jpg" },
                new Arma { Id = 5, Nome = "Sabre de Luz", Image="http://geekcafe.blog.br/wp-content/uploads/2015/12/sabre-de-luz-de-verdade.jpg" },
                new Arma { Id = 6, Nome = "Bomba", Image="https://thumbs.dreamstime.com/x/bomba-do-mal-dos-desenhos-animados-19223749.jpg" }};
        }
    }
}
