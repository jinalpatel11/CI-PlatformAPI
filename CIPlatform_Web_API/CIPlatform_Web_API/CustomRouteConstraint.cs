namespace CIPlatform_Web_API
{
    using System.Net.Http;
    using System.Web.Http.Routing;

    public class CustomRouteConstraint : IHttpRouteConstraint
    {
        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values, HttpRouteDirection routeDirection)
        {
            // Implement your custom constraint logic here
            // The `request` parameter provides access to the current request
            // The `route` parameter represents the route definition
            // The `parameterName` parameter is the name of the route parameter being checked
            // The `values` parameter contains the route parameter values
            // The `routeDirection` parameter indicates whether the constraint is being checked during route generation or route matching

            // Return true if the constraint is satisfied; otherwise, return false
            // For example, you can check if the parameter value matches a specific pattern or meets certain conditions

            // Here's an example constraint that checks if the parameter value is an integer
            if (values.TryGetValue(parameterName, out object parameterValue))
            {
                if (int.TryParse(parameterValue.ToString(), out _))
                {
                    return true;
                }
            }

            return false;
        }
    }

}
