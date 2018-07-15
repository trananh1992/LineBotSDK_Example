﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineBotSDK.Struct;
using LineBotSDK.Struct.Messages;
using LineBotSDK.Utility;

namespace LineBotSDK_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = ""; // please input the line bot token
            string userid = "";// please input the user id
            string image_url = "https://i0.wp.com/blog.patw.me/wp-content/uploads/2017/05/ZcNMMLg.png?fit=800%2C416&ssl=1";
            string mp4_url = "https://www.legacyvet.com/sites/default/files/videos/Video%20%281%29.mp4";

            // Send the text message to user
            MessageUtility.PushTextMessage(token, userid, "Hi");

            // Send the image message to user
            MessageUtility.PushImageMessage(token, userid, image_url, image_url);

            // Send the video message to user
            MessageUtility.PushVideoMessage(token, userid, mp4_url, image_url);

            // Send the sticker message to user
            MessageUtility.PushStickerMessage(token, userid, "1", "1");

            // Send the audio message to user, but I don't find the audio file
            //MessageUtility.PushAudioMessage();

            // Send the location message to user
            MessageUtility.PushLocationMessage(token, userid, "hi", "address:123", (decimal)35.65910807942215, (decimal)139.70372892916203);

            // Send the imagemap message to user
            Size size = new Size(800, 416);
            var actions = new List<IImagemapAction>();
            actions.Add(new ImagemapMessageAction("text", new ImagemapArea(0, 0, 400, 416)));
            actions.Add(new ImagemapURIAction("https://goolgle.com.tw", new ImagemapArea(400, 0, 400, 416)));
            MessageUtility.PushImagemapMessage(token, userid, image_url, "altText", size, actions);

        }
    }
}
