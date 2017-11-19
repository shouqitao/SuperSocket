﻿using System;
using System.Threading.Tasks;

namespace SuperSocket.Channel
{
    public interface IChannel
    {
        Task SendAsync(ArraySegment<byte> data);

        Task<ArraySegment<byte>> ReceiveAsync();

        void Close();

        event EventHandler Closed;
    }
}
