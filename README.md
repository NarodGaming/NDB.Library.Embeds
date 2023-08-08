# An Embed provider for Discord.NET Bots

This library provides Discord.NET bots, including NDB, with easy embed functionality.

## How do I use this library?

For all bots (NDB, other & custom):

1. Download (or compile) this library.
2. Add a reference to this library in your Discord Bot (usually right click project on right hand side -> Add Reference)
3. In each source code file you want to use the library, add it to your imports/using. e.g.
    - for VB, `Imports NDB.Library.Embeds` would be added underneath your other imports, above your namespace / class declaration.
    - for C#, `using NDB.Library.Embeds;` would be added underneath your other imports, above your namespace / class declaration.
4. You can then create embeds by calling `Embeds.ReplyEmbedAsync()`