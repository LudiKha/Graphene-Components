
using UnityEngine;
using UnityEngine.Events;

namespace Graphene.ViewModel
{
  // Atomic "Über" object for the view
  [System.Serializable, Draw(ControlType.Button)]
  public class BindableObject : IRoute, ICustomControlType
  {
    [field: SerializeField]
    public ControlType ControlType { get; set; }

    [field: SerializeField]
    [Bind("Label", BindingMode.OneWay)]
    public string Name { get; set; }

    [field: SerializeField]
    [Bind("Value")]
    public string Value { get; set; }

    [field: SerializeField]
    [Route]
    public string route;

    [field: SerializeField]
    [BindTooltip("Description")]
    public string Description { get; set; }

    
    [field: SerializeField][Bind("Image")]
    public Texture Image { get; private set; }

    #region FoldoutAttribute
#if ODIN_INSPECTOR
    [Sirenix.OdinInspector.FoldoutGroup("Additionals")]
#elif NAUGHTY_ATTRIBUTES
    [NaughtyAttributes.Foldout("Additionals")]
#endif
    #endregion
    public string addClass;

    #region FoldoutAttribute
#if ODIN_INSPECTOR
    [Sirenix.OdinInspector.FoldoutGroup("Additionals")]
#elif NAUGHTY_ATTRIBUTES
    [NaughtyAttributes.Foldout("Additionals")]
#endif
    #endregion
    [Bind("")]
    public UnityEvent OnClick;
  }
}
