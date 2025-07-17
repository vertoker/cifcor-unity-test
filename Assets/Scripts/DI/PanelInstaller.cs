using Panel;
using Zenject;

namespace DI
{
    public class PanelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PanelController>().AsSingle();
        }
    }
}