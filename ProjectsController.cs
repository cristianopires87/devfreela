﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet ]

        public IActionResult Get(string query)
        {
            return Ok();
        }

        [HttpGet("id")]

        public IActionResult GetById(int id) 
        {
        
        }
    }
}
