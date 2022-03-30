using Abstractions;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UserControlSystem;

namespace Presenter
{
    public class MouseInteractionPresenter : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private SelectableValue _selectedObject;
        [SerializeField] private EventSystem _eventSystem;

        private void Update()
        {
            // пока отключил, так как UI заслоняет весь экран и поэтому outline не работает
            //if (!_eventSystem.IsPointerOverGameObject())
            //    return;

            if (!Input.GetMouseButtonUp(0))
                return;

            var hits = Physics.RaycastAll(_camera.ScreenPointToRay(Input.mousePosition));

            if (hits.Length == 0)
                return;
            
            var selectable = hits
                .Select(hit => hit.collider.GetComponentInParent<ISelectable>())
                .Where(c => c != null)
                .FirstOrDefault();

            _selectedObject.SetValue(selectable);
        }
    }
}
