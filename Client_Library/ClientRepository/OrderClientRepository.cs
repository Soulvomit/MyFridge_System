﻿using Client_Library.Abstract;
using Client_Library.Interface;
using Client_Model;

namespace Client_Library.ClientRepository
{
    public class OrderClientRepository : ClientRepository<OrderCto>, IOrderClientRepository
    {
        public OrderClientRepository(string baseAddress) : base(baseAddress) { }
    }
}
