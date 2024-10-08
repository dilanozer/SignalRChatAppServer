﻿using SignalRChatServerExample.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>policy
      .AllowCredentials()
      .AllowAnyHeader()
      .SetIsOriginAllowed(x => true)));
builder.Services.AddSignalR();

var app = builder.Build();

app.UseCors();
app.UseRouting();
app.MapHub<ChatHub>("/chathub");

app.Run();

