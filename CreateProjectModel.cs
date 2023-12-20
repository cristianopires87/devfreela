using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DevFreela.Model
{
    public class CreateProjectModelo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }

}
