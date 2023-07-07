using System.Collections.Generic;

namespace PorfolioRubenSanchez.Models
{
    public interface IProjectsRepo
    {
        List<Project> GetProjects();
    }
    public class ProjectsRepo : IProjectsRepo
    {
        public List<Project> GetProjects()
        {

            return new List<Project>()
            {
                new Project
                {
                    ImageURL = "/img/Filmoteca.png",
                    ImageHoverURL = "/img/FilmotecaHover.png",
                    Title = "Filmoteca WebApp",
                    Date = "jan 2023 - march 2023",
                    Description = "We met some of Lewagon's students and made this web app starting from scratch.",
                    Link = "http://filmoteca.herokuapp.com",
                    LinkGithub ="https://github.com/RdzYogi/filmoteca",
                    
                },
                 new Project
                {
                    ImageURL = "/img/SportsIn.png",
                    ImageHoverURL = "/img/SportsIn_hover.png",
                    Title = "SportsIn",
                    Date = "Dec 2022",
                    Description = "We create  this web app starting from scratch.",
                    Link = "",
                    LinkGithub ="",
                },
            };
        }
    }
}
