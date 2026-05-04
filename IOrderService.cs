namespace sharp_lessons10
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDto>> GetAllAsync();
        Task<OrderDto?> GetByIdAsync(int id);
        Task<OrderDto> CreateAsync(OrderDto order);
        Task UpdateAsync(int id, OrderDto order);
        Task DeleteAsync(int id);
    }
}
