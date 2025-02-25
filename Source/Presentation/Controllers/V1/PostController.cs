﻿using Application.Features.Post.Commands.CreatePost;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers.V1;

[Route("Api/V{version:apiVersion}/[controller]/[action]")]
[ApiVersion("1.0", Deprecated = true)]
public class PostController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<int>> Create(CreatePostCommand command)
    {
        return await Mediator.Send(command);
    }
}
