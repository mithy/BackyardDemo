//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public NotebookAlertComponent notebookAlert { get { return (NotebookAlertComponent)GetComponent(GameComponentsLookup.NotebookAlert); } }
    public bool hasNotebookAlert { get { return HasComponent(GameComponentsLookup.NotebookAlert); } }

    public void AddNotebookAlert(bool newIsDisplayingAlert) {
        var index = GameComponentsLookup.NotebookAlert;
        var component = CreateComponent<NotebookAlertComponent>(index);
        component.IsDisplayingAlert = newIsDisplayingAlert;
        AddComponent(index, component);
    }

    public void ReplaceNotebookAlert(bool newIsDisplayingAlert) {
        var index = GameComponentsLookup.NotebookAlert;
        var component = CreateComponent<NotebookAlertComponent>(index);
        component.IsDisplayingAlert = newIsDisplayingAlert;
        ReplaceComponent(index, component);
    }

    public void RemoveNotebookAlert() {
        RemoveComponent(GameComponentsLookup.NotebookAlert);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherNotebookAlert;

    public static Entitas.IMatcher<GameEntity> NotebookAlert {
        get {
            if (_matcherNotebookAlert == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.NotebookAlert);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherNotebookAlert = matcher;
            }

            return _matcherNotebookAlert;
        }
    }
}
