using Microsoft.AspNetCore.Mvc;

namespace sharp_lessons10
{
    public class OrderService : IOrderService
    {
        private static readonly List<OrderDto> _orders = new();

        public async Task<IEnumerable<OrderDto>> GetAllAsync() => await Task.FromResult(_orders);

        public async Task<OrderDto?> GetByIdAsync(int id) =>
            await Task.FromResult(_orders.FirstOrDefault(o => o.Id == id));

        public async Task<OrderDto> CreateAsync(OrderDto order)
        {
            order.Id = _orders.Count + 1;
            _orders.Add(order);
            return await Task.FromResult(order);
        }

        public async Task UpdateAsync(int id, OrderDto order)
        {
            var existing = _orders.FirstOrDefault(o => o.Id == id);
            if (existing != null)
            {
                existing.CustomerName = order.CustomerName;
                existing.TotalAmount = order.TotalAmount;
            }
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            _orders.RemoveAll(o => o.Id == id);
            await Task.CompletedTask;
        }
    }
}
