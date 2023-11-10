using NPaperless.Services.Controllers;
using NPaperless.Services.DTOs;
using AutoMapper;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Tests;
//namespace NPaperless.Services.Tests

public class Tests
{
    private CorrespondentsApiController _correspondentsAPI;
    private readonly IMapper _mapper;
    [SetUp]
    public void Setup()
    {
        _correspondentsAPI = new CorrespondentsApiController(_mapper);
    }

    [Test]
    public void CreateCorrespondent_with_valid_newCorrespondentDTO()
    {
        var NewCorrespondent = new Correspondent
        {
        LastCorrespondence= new DateTime(2023, 11, 10, 13, 16, 0),
        DocumentCount = 2,
        IsInsensitive = true,
        MatchingAlgorithm= 2,
        Match= "",
        Name= "Test",
        Slug= "Slug",
        Id= 2
        };
        var result = _correspondentsAPI.CreateCorrespondent(NewCorrespondent);
        Assert.IsInstanceOf<OkResult>(result);
    }

    public void CreateCorrespondent_with_invalid_newCorrespondentDTO()
    {
        var NewCorrespondent = new Correspondent();
        var result = _correspondentsAPI.CreateCorrespondent(NewCorrespondent);
        Assert.IsInstanceOf<BadRequestResult>(result);
    }
}