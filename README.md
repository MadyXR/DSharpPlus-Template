# DSharpPlus Template

This is a simple and easy-to-use template for building Discord bots using the [DSharpPlus](https://github.com/DSharpPlus/DSharpPlus) library in C#. It provides the basic structure needed to quickly start building and deploying your own Discord bot.

## Features

- Simple and minimal template to get started with Discord bots in C#.
- Preconfigured for easy bot setup with DSharpPlus.
- Includes basic bot event handling (e.g., `Ready` event).
- Can be easily extended with custom commands and event handlers.

## Prerequisites

Before running this project, make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download/dotnet) (5.0 or higher)
- A Discord account
- A Discord bot token (you can create a bot and get your token from the [Discord Developer Portal](https://discord.com/developers/applications))

## Required Packages and Libraries

This template uses the following NuGet packages to interact with Discord:

- **DSharpPlus**: The main library for building Discord bots in C#.
  ```bash
  dotnet add package DSharpPlus
- **DSharpPlus.CommandsNext**: The Command library for Discord bots in C#.
  ```bash
  dotnet add package DSharpPlus.CommandsNext
- **Newtonsoft.Json**: The add JSON library files library in C#.
  ```bash
  dotnet add package Newtonsoft.Json
