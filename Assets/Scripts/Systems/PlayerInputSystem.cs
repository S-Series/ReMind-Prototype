//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerInputSystem.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputSystem : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputSystem"",
    ""maps"": [
        {
            ""name"": ""OnMenu"",
            ""id"": ""453f31a4-71b6-496b-8a3a-335e7119de3c"",
            ""actions"": [
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""e740f9e8-1200-4ac1-a958-f6a423ec05b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""983935fa-5717-444f-b587-f88b719c335d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""9d99f333-bad9-41a7-a932-0189f017b96c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""7a819218-73e4-471a-a51f-f653b1cf2d75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""f9a32fde-37ed-4c4e-b978-87f37c1b8e73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""0edb58f3-bbd5-482c-8804-cbbebac4bf89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""17b5c4a2-102e-43ff-b31f-b058c36b6f62"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e55c47ae-04f5-4338-a5a4-fed095e8eb9a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""483dd49c-f1fe-4b59-98e2-954174479f0d"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38dd7fd1-4f25-4688-a9b5-ff7bf749b878"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""022c021c-d60c-435c-87dc-cf2dae24b5b4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0622615a-21a7-4395-b94f-25e60007c4c6"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""658184fa-a261-41da-be8e-d58a40c59056"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80949bd3-9a6f-4525-a4fc-ad5dcc80fb94"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a42ca07d-80f4-46d5-8df4-7e3c9bd1e843"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67bfde8d-b310-4d68-bced-9d7e12977458"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a13875ae-c2a3-446b-9931-979cd1ef5458"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""987b099c-e418-4a85-a8ab-d4010e7a2b12"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e7570b7-9b81-41e7-8310-00c1b072b70a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd6fe77e-3c9f-478d-9c9f-3554da048f2f"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a547f49-4758-44fc-b627-da2295a9decd"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a254d8fe-fb51-4383-9ee5-5bdfb3ec7512"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GamePlay"",
            ""id"": ""c0efda50-31ec-43fa-be49-9b7f717a6a97"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""0abdf9a7-33da-4115-9454-cf609e060ff8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""10681b3c-a1a7-4e96-a0b0-8102f5c67aaf"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // OnMenu
        m_OnMenu = asset.FindActionMap("OnMenu", throwIfNotFound: true);
        m_OnMenu_MoveUp = m_OnMenu.FindAction("MoveUp", throwIfNotFound: true);
        m_OnMenu_MoveDown = m_OnMenu.FindAction("MoveDown", throwIfNotFound: true);
        m_OnMenu_MoveLeft = m_OnMenu.FindAction("MoveLeft", throwIfNotFound: true);
        m_OnMenu_MoveRight = m_OnMenu.FindAction("MoveRight", throwIfNotFound: true);
        m_OnMenu_Cancel = m_OnMenu.FindAction("Cancel", throwIfNotFound: true);
        m_OnMenu_Select = m_OnMenu.FindAction("Select", throwIfNotFound: true);
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Newaction = m_GamePlay.FindAction("New action", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // OnMenu
    private readonly InputActionMap m_OnMenu;
    private IOnMenuActions m_OnMenuActionsCallbackInterface;
    private readonly InputAction m_OnMenu_MoveUp;
    private readonly InputAction m_OnMenu_MoveDown;
    private readonly InputAction m_OnMenu_MoveLeft;
    private readonly InputAction m_OnMenu_MoveRight;
    private readonly InputAction m_OnMenu_Cancel;
    private readonly InputAction m_OnMenu_Select;
    public struct OnMenuActions
    {
        private @PlayerInputSystem m_Wrapper;
        public OnMenuActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveUp => m_Wrapper.m_OnMenu_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_OnMenu_MoveDown;
        public InputAction @MoveLeft => m_Wrapper.m_OnMenu_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_OnMenu_MoveRight;
        public InputAction @Cancel => m_Wrapper.m_OnMenu_Cancel;
        public InputAction @Select => m_Wrapper.m_OnMenu_Select;
        public InputActionMap Get() { return m_Wrapper.m_OnMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnMenuActions set) { return set.Get(); }
        public void SetCallbacks(IOnMenuActions instance)
        {
            if (m_Wrapper.m_OnMenuActionsCallbackInterface != null)
            {
                @MoveUp.started -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveUp;
                @MoveDown.started -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveDown;
                @MoveLeft.started -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnMoveRight;
                @Cancel.started -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnCancel;
                @Select.started -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_OnMenuActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_OnMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public OnMenuActions @OnMenu => new OnMenuActions(this);

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Newaction;
    public struct GamePlayActions
    {
        private @PlayerInputSystem m_Wrapper;
        public GamePlayActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_GamePlay_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IOnMenuActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IGamePlayActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
