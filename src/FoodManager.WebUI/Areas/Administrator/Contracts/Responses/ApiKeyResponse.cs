﻿using FoodManager.WebUI.Contracts;

namespace FoodManager.WebUI.Areas.Administrator.Contracts.Responses;

public sealed class ApiKeyResponse : ResponseBase
{
    public ApiKey[] Data { get; set; }
}
