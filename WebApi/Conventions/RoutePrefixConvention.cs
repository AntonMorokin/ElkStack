using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Linq;

namespace WebApi.Conventions
{
    public class RoutePrefixConvention : IApplicationModelConvention
    {
        private readonly AttributeRouteModel _routePrefixModel;

        public RoutePrefixConvention()
        {
            _routePrefixModel = new AttributeRouteModel(new RouteAttribute(Constants.EndpointRoutes.ApiPrefix));
        }

        public void Apply(ApplicationModel application)
        {
            foreach (var selector in application.Controllers.SelectMany(c => c.Selectors))
            {
                if (selector.AttributeRouteModel != null)
                {
                    selector.AttributeRouteModel = AttributeRouteModel.CombineAttributeRouteModel(_routePrefixModel, selector.AttributeRouteModel);
                }
                else
                {
                    selector.AttributeRouteModel = _routePrefixModel;
                }
            }
        }
    }
}
