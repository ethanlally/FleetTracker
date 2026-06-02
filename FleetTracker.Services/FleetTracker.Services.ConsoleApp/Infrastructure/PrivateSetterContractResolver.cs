using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FleetTracker.Services.ConsoleApp.Infrastructure
{
    public class PrivateSetterContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var jProperty = base.CreateProperty(member, memberSerialization);
            if (jProperty.Writable)
                return jProperty;

            var propertyInfo = member as PropertyInfo;
            if (propertyInfo != null)
            {
                var hasPrivateSetter = propertyInfo.GetSetMethod(true) != null;
                jProperty.Writable = hasPrivateSetter;
            }

            return jProperty;
        }
    }
}
