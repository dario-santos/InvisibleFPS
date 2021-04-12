// GENERATED AUTOMATICALLY FROM 'Assets/FPS/Scripts/Gameplay/Managers/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControllerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControllerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""PlayerController"",
            ""id"": ""e7a7a32f-ca68-4f7e-b42a-4ebf25929048"",
            ""actions"": [
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""ce3c992c-7b62-406c-9d7b-3e129889cbd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""Value"",
                    ""id"": ""c1d6264d-ea41-4de1-be7f-6f652deac0ce"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""413de8cd-9421-4118-b1b4-ff68f3615d32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""1285395a-d3d3-4ba6-bc6d-671183760a1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""87b9fc97-d789-4b14-8c92-861f2c322c88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerMovement"",
                    ""type"": ""Value"",
                    ""id"": ""8f8079d4-809f-44b7-baf1-78e6fad17640"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a3a9a66-3413-42b2-8b62-d7667ef60a34"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a261af0-e04b-4030-a06a-b0d7092d0e3c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01dfa7b8-76f0-47ed-ba77-b8ab0a183c81"",
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
                    ""id"": ""eebc1c7b-53da-4f70-a3f1-f4952fb5b3b1"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e95c57d-ff9f-4d3e-b6d6-537f20e90c5e"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""137f17da-44fb-417f-9fda-caa283263288"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerController
        m_PlayerController = asset.FindActionMap("PlayerController", throwIfNotFound: true);
        m_PlayerController_Aim = m_PlayerController.FindAction("Aim", throwIfNotFound: true);
        m_PlayerController_CameraMovement = m_PlayerController.FindAction("CameraMovement", throwIfNotFound: true);
        m_PlayerController_Crouch = m_PlayerController.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerController_Fire = m_PlayerController.FindAction("Fire", throwIfNotFound: true);
        m_PlayerController_Jump = m_PlayerController.FindAction("Jump", throwIfNotFound: true);
        m_PlayerController_PlayerMovement = m_PlayerController.FindAction("PlayerMovement", throwIfNotFound: true);
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

    // PlayerController
    private readonly InputActionMap m_PlayerController;
    private IPlayerControllerActions m_PlayerControllerActionsCallbackInterface;
    private readonly InputAction m_PlayerController_Aim;
    private readonly InputAction m_PlayerController_CameraMovement;
    private readonly InputAction m_PlayerController_Crouch;
    private readonly InputAction m_PlayerController_Fire;
    private readonly InputAction m_PlayerController_Jump;
    private readonly InputAction m_PlayerController_PlayerMovement;
    public struct PlayerControllerActions
    {
        private @PlayerControllerInput m_Wrapper;
        public PlayerControllerActions(@PlayerControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aim => m_Wrapper.m_PlayerController_Aim;
        public InputAction @CameraMovement => m_Wrapper.m_PlayerController_CameraMovement;
        public InputAction @Crouch => m_Wrapper.m_PlayerController_Crouch;
        public InputAction @Fire => m_Wrapper.m_PlayerController_Fire;
        public InputAction @Jump => m_Wrapper.m_PlayerController_Jump;
        public InputAction @PlayerMovement => m_Wrapper.m_PlayerController_PlayerMovement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControllerActions instance)
        {
            if (m_Wrapper.m_PlayerControllerActionsCallbackInterface != null)
            {
                @Aim.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnAim;
                @CameraMovement.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovement;
                @Crouch.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCrouch;
                @Fire.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnFire;
                @Jump.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                @PlayerMovement.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPlayerMovement;
            }
            m_Wrapper.m_PlayerControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @PlayerMovement.started += instance.OnPlayerMovement;
                @PlayerMovement.performed += instance.OnPlayerMovement;
                @PlayerMovement.canceled += instance.OnPlayerMovement;
            }
        }
    }
    public PlayerControllerActions @PlayerController => new PlayerControllerActions(this);
    public interface IPlayerControllerActions
    {
        void OnAim(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPlayerMovement(InputAction.CallbackContext context);
    }
}
