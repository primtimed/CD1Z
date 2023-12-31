//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/brian/Movement/PlayerControlls.inputactions
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

public partial class @PlayerControlls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""Deafult Movement"",
            ""id"": ""1002f397-98b9-48fe-87ba-12fbb4d6b2ac"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a8603a35-608f-458f-a93a-10414996f1f1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""140e4e71-3f29-4f12-bfc8-277d6b7bd5d8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fecf2d47-8106-4b39-97f5-2e929f8f327d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mouse Lock"",
                    ""type"": ""Button"",
                    ""id"": ""21b3016b-d0e0-4e73-b412-85bf8697bc18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""a658003f-1ca2-4087-bfe2-28d26ed45660"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""2658aaab-ac71-472d-9a21-21a44a725fc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""a1b190c0-08d9-4aab-ab92-3df8ac4147ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""W,A,S,D"",
                    ""id"": ""3b3be98d-8f78-4a5e-89ef-401172faad37"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""48b3036f-1bad-47bf-87e7-139a118b48d2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b7aed4ce-65a4-4d5e-97cf-8534cfa015c6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a429453d-6152-458a-9451-6b42eedf280c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""8544fecb-d79a-4a73-8341-c01d4e89a4da"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fe975137-980f-4922-91d1-3b10e688d45d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7587a9c-11c2-4d49-a477-b41c7443278e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80f96fe2-e217-488f-bb81-fedfe7d40fd4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5d55db9-8a5f-49b4-a325-afe581ac6143"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Lock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf365fc6-6c7e-4c9d-b795-be48143ad80d"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Lock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e35d0f1-17f9-41f9-bb1a-7e93ee8f36fa"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d6a65d2-7164-493d-ab0e-6cb6c5eb49e5"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6930afe9-2c78-441f-8c05-9567581afb0b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aee8bb4-4b69-413e-8b4d-681a016319ad"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c844494b-0e84-4e1d-aff1-b13442944a05"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4f490b2-be59-42b8-9e78-ca27d9a984d9"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Deafult Movement
        m_DeafultMovement = asset.FindActionMap("Deafult Movement", throwIfNotFound: true);
        m_DeafultMovement_Movement = m_DeafultMovement.FindAction("Movement", throwIfNotFound: true);
        m_DeafultMovement_Rotation = m_DeafultMovement.FindAction("Rotation", throwIfNotFound: true);
        m_DeafultMovement_Jump = m_DeafultMovement.FindAction("Jump", throwIfNotFound: true);
        m_DeafultMovement_MouseLock = m_DeafultMovement.FindAction("Mouse Lock", throwIfNotFound: true);
        m_DeafultMovement_Sprint = m_DeafultMovement.FindAction("Sprint", throwIfNotFound: true);
        m_DeafultMovement_Shoot = m_DeafultMovement.FindAction("Shoot", throwIfNotFound: true);
        m_DeafultMovement_Reload = m_DeafultMovement.FindAction("Reload", throwIfNotFound: true);
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

    // Deafult Movement
    private readonly InputActionMap m_DeafultMovement;
    private IDeafultMovementActions m_DeafultMovementActionsCallbackInterface;
    private readonly InputAction m_DeafultMovement_Movement;
    private readonly InputAction m_DeafultMovement_Rotation;
    private readonly InputAction m_DeafultMovement_Jump;
    private readonly InputAction m_DeafultMovement_MouseLock;
    private readonly InputAction m_DeafultMovement_Sprint;
    private readonly InputAction m_DeafultMovement_Shoot;
    private readonly InputAction m_DeafultMovement_Reload;
    public struct DeafultMovementActions
    {
        private @PlayerControlls m_Wrapper;
        public DeafultMovementActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_DeafultMovement_Movement;
        public InputAction @Rotation => m_Wrapper.m_DeafultMovement_Rotation;
        public InputAction @Jump => m_Wrapper.m_DeafultMovement_Jump;
        public InputAction @MouseLock => m_Wrapper.m_DeafultMovement_MouseLock;
        public InputAction @Sprint => m_Wrapper.m_DeafultMovement_Sprint;
        public InputAction @Shoot => m_Wrapper.m_DeafultMovement_Shoot;
        public InputAction @Reload => m_Wrapper.m_DeafultMovement_Reload;
        public InputActionMap Get() { return m_Wrapper.m_DeafultMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DeafultMovementActions set) { return set.Get(); }
        public void SetCallbacks(IDeafultMovementActions instance)
        {
            if (m_Wrapper.m_DeafultMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnMovement;
                @Rotation.started -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnRotation;
                @Jump.started -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnJump;
                @MouseLock.started -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnMouseLock;
                @MouseLock.performed -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnMouseLock;
                @MouseLock.canceled -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnMouseLock;
                @Sprint.started -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnSprint;
                @Shoot.started -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnShoot;
                @Reload.started -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_DeafultMovementActionsCallbackInterface.OnReload;
            }
            m_Wrapper.m_DeafultMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseLock.started += instance.OnMouseLock;
                @MouseLock.performed += instance.OnMouseLock;
                @MouseLock.canceled += instance.OnMouseLock;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
            }
        }
    }
    public DeafultMovementActions @DeafultMovement => new DeafultMovementActions(this);
    public interface IDeafultMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseLock(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
}
