# An Embed provider for Discord.NET Bots

This library provides Discord.NET bots, including [NDB.Main](https://github.com/NarodGaming/NDB.Main), with easy embed functionality.

## How do I use this library?

For all bots (NDB, other & custom):

1. Download (or compile) this library.
2. Add a reference to this library in your Discord Bot (usually right click project on right hand side -> Add Reference)
3. In each source code file you want to use the library, add it to your imports/using. e.g.
    - for VB, `Imports NDB.Library.Embeds` would be added underneath your other imports, above your namespace / class declaration.
    - for C#, `using NDB.Library.Embeds;` would be added underneath your other imports, above your namespace / class declaration.
4. Add lines to your `config.json`, specifically: `botname` and `embedcolour`.
    - botname should be the readable version of your bot's name, such as `My Discord Bot` or `Example Bot`
    - embedcolour should be a hex value of the colour of the embed.
5. Add this is a dependency to [NDB.Loader](https://github.com/NarodGaming/NDB.Loader), if used.
6. You can then create embeds by calling `Embeds.ReplyEmbedAsync()`