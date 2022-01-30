using Discount.Grpc.Protos;
using System.Threading.Tasks;

namespace Basket.Api.GrpCServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoService;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoService)
        {
            _discountProtoService = discountProtoService;
        }

        public async Task<CouponModel>GetDiscount(string productName)
        {
            var discountRequwst = new GetDiscountRequest { ProductName = productName };
            return await _discountProtoService.GetDiscountAsync(discountRequwst);
        }
    }
}
