﻿using BIMicon.BIMiconUI.Enums;

namespace BIMicon.BIMiconUI.Models
{
    public class Message
    {
        public readonly string Content;
        public readonly string Title;
        public readonly MessageType Type;

        public Message(MessageType type, string title, string content)
        {
            Type = type;
            Title = title;
            Content = content;
        }
    }
}
