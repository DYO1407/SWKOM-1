/*
 * Mock Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using NPaperless.Services.Attributes;
using NPaperless.Services.DTOs;
using AutoMapper;

namespace NPaperless.Services.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class CorrespondentsApiController : ControllerBase
    {



        private readonly IMapper _mapper;


        public CorrespondentsApiController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public CorrespondentsApiController()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newCorrespondent"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/correspondents")]
        [Consumes("application/json", "text/json", "application/*+json")]
        [ValidateModelState]
        [SwaggerOperation("CreateCorrespondent")]
        public virtual IActionResult CreateCorrespondent([FromBody]Correspondent newCorrespondent)
        {
           if (newCorrespondent == null)
        {
            return BadRequest("Invalid input");
        }

        try
        {
            // Mapping von DTO zu Entität
            var correspondentEntity = _mapper.Map<BusinessLogic.Entities.Correspondent>(newCorrespondent);

            //Businesslogic todo 

            // chech if mapping works 
            return Ok(correspondentEntity);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            //             return StatusCode(200);

            //          throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpDelete]
        [Route("/api/correspondents/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteCorrespondent")]
        public virtual IActionResult DeleteCorrespondent([FromRoute (Name = "id")][Required]int id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/correspondents")]
        [ValidateModelState]
        [SwaggerOperation("GetCorrespondents")]
        public virtual IActionResult GetCorrespondents()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            //return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="correspondent"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/api/correspondents/{id}")]
        [Consumes("application/json", "text/json", "application/*+json")]
        [ValidateModelState]
        [SwaggerOperation("UpdateCorrespondent")]
        public virtual IActionResult UpdateCorrespondent([FromRoute (Name = "id")][Required]int id, [FromBody]Correspondent correspondent)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
