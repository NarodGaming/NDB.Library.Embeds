using Discord;
using Discord.WebSocket;

namespace NDB.Library.Embeds
{
    public static class Embeds
    {
        public static Embed EmbedBuilder(String content, String title = "", String picture = "")
        {
            EmbedBuilder builder = new();
            String? startTitle = NDB_Main._config["botname"];
            if (startTitle != null) { builder.Title = NDB_Main._config["botname"]; } else { title = "NDB"; }
            if (title != "") { builder.Title += " | " + title; }
            if (picture != "") { builder.ImageUrl= picture; }
            builder.Color = new Color(0x607D8B);
            builder.Description = content;
            return builder.Build();
        }

        public static Task ReplyEmbedAsync(ISocketMessageChannel responseChannel, String content, String title = "", String picture = "")
        {
            return responseChannel.SendMessageAsync("", false, EmbedBuilder(content, title, picture));
        }
    }
}