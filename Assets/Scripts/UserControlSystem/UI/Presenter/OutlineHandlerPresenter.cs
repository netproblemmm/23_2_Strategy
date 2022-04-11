using Abstractions;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UserControlSystem;

namespace Presenter
{
    class OutlineHandlerPresenter : MonoBehaviour
    {
        [SerializeField] private SelectableValue _selectable;
        private ISelectable _currentSelected;
        private List<IOutlineDrawer> _currentOutline = new List<IOutlineDrawer>();

        private void Start() {
            _selectable.OnNewValue += OnSelected;
        }

        private void OnSelected(ISelectable selectable) {
            if (_currentSelected == selectable) {
                return;
            }

            _currentOutline.ForEach(z => z.SetOutline(false));
            _currentOutline.Clear();
            _currentSelected = selectable;

            if (selectable is Component) {
                _currentOutline = (selectable as Component).GetComponents<IOutlineDrawer>().ToList();
                _currentOutline.ForEach(z => z.SetOutline(true));
            }
        }
    }
}
