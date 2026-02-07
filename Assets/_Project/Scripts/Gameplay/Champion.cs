using Moba.Core;
using Unity.Netcode;
using UnityEngine;

namespace Moba.Gameplay
{
    public class Champion : NetworkBehaviour, IUnitStats
    {
        public int Health => 100;

        public override void OnNetworkSpawn()
        {
            // Se este log aparecer, o Netcode inicializou o script com sucesso
            Debug.Log($"[Champion] Spawnado! Sou Dono? {IsOwner}. Vida Inicial: {Health}");

            // Teste de Sanidade da Interface
            TestInterfaceAccess();
        }

        private void TestInterfaceAccess()
        {
            // Polimorfismo: Tratando a si mesmo como a interface do Core
            IUnitStats stats = this;
            if (stats.Health == 1000)
            {
                Debug.Log("[System] Arquitetura OK: Gameplay acessou Core via Interface.");
            }
        }

    }
}
