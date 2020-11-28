using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SportsStore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class SessionProduct : Productdisplay
    {
        public static Productdisplay GetProduct(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
            .HttpContext.Session;
            SessionProduct product = session?.GetJson<SessionProduct>("Product")
            ?? new SessionProduct();
            product.Session = session;
            return product;
        }
        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session.SetJson("Product", this);
        }
        public override void RemoveLine(Product product)
        {
            base.RemoveLine(product);
            Session.SetJson("Product", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.Remove("Product");
            
        }
    }
}
