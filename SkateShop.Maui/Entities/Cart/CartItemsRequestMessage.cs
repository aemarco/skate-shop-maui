﻿using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateShop.Maui.Entities.Cart
{
    public class CartItemsRequestMessage : RequestMessage<IEnumerable<CartItem>> { }
}
