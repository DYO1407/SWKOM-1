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
    public class DocumentsApiController : ControllerBase
    { 

         private readonly IMapper _mapper;


        public DocumentsApiController(IMapper mapper)
        {
            _mapper = mapper;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpDelete]
        [Route("/api/documents/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteDocument")]
        public virtual IActionResult DeleteDocument([FromRoute (Name = "id")][Required]int id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="original"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}/download")]
        [ValidateModelState]
        [SwaggerOperation("DownloadDocument")]
        public virtual IActionResult DownloadDocument([FromRoute (Name = "id")][Required]int id, [FromQuery (Name = "original")]bool? original)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}/metadata")]
        [ValidateModelState]
        [SwaggerOperation("GetDocumentMetadata")]
        public virtual IActionResult GetDocumentMetadata([FromRoute (Name = "id")][Required]int id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}/preview")]
        [ValidateModelState]
        [SwaggerOperation("GetDocumentPreview")]
        public virtual IActionResult GetDocumentPreview([FromRoute (Name = "id")][Required]int id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}/thumb")]
        [ValidateModelState]
        [SwaggerOperation("GetDocumentThumb")]
        public virtual IActionResult GetDocumentThumb([FromRoute (Name = "id")][Required]int id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="query"></param>
        /// <param name="ordering"></param>
        /// <param name="tagsIdAll"></param>
        /// <param name="documentTypeId"></param>
        /// <param name="correspondentId"></param>
        /// <param name="truncateContent"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents")]
        [ValidateModelState]
        [SwaggerOperation("GetDocuments")]
        public virtual IActionResult GetDocuments([FromQuery (Name = "Page")]int? page, [FromQuery (Name = "page_size")]int? pageSize, [FromQuery (Name = "query")]string query, [FromQuery (Name = "ordering")]string ordering, [FromQuery (Name = "tags__id__all")]List<int> tagsIdAll, [FromQuery (Name = "document_type__id")]int? documentTypeId, [FromQuery (Name = "correspondent__id")]int? correspondentId, [FromQuery (Name = "truncate_content")]bool? truncateContent)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="document"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/api/documents/{id}")]
        [Consumes("application/json", "text/json", "application/*+json")]
        [ValidateModelState]
        [SwaggerOperation("UpdateDocument")]
        public virtual IActionResult UpdateDocument([FromRoute (Name = "id")][Required]int id, [FromBody]Document document)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="created"></param>
        /// <param name="documentType"></param>
        /// <param name="tags"></param>
        /// <param name="correspondent"></param>
        /// <param name="document"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/documents/post_document")]
        [Consumes("multipart/form-data")]
        [ValidateModelState]
        [SwaggerOperation("UploadDocument")]
        public virtual IActionResult UploadDocument([FromForm (Name = "title")]string title, [FromForm (Name = "created")]DateTime? created, [FromForm (Name = "document_type")]int? documentType, [FromForm (Name = "tags")]List<int> tags, [FromForm (Name = "correspondent")]int? correspondent, [FromForm (Name = "document")]List<System.IO.Stream> document)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
