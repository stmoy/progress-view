using Microsoft.ReactNative;
using Microsoft.ReactNative.Managed;

namespace progress_view_windows
{
    public sealed class ReactPackageProvider : IReactPackageProvider
    {
        public void CreatePackage(IReactPackageBuilder packageBuilder)
        {
            packageBuilder.AddViewManagers();
        }
    }
}
