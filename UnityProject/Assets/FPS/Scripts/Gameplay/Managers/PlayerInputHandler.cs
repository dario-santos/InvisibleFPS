using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Unity.FPS.Gameplay
{
    public class PlayerInputHandler : MonoBehaviour
    {
        [Tooltip("Sensitivity multiplier for moving the camera around")]
        public float LookSensitivity = 1f;

        [Tooltip("Additional sensitivity multiplier for WebGL")]
        public float WebglLookSensitivityMultiplier = 0.25f;

        [Tooltip("Limit to consider an input when using a trigger on a controller")]
        public float TriggerAxisThreshold = 0.4f;

        [Tooltip("Used to flip the vertical input axis")]
        public bool InvertYAxis = false;

        [Tooltip("Used to flip the horizontal input axis")]
        public bool InvertXAxis = false;

        GameFlowManager m_GameFlowManager;
        PlayerCharacterController m_PlayerCharacterController;
        bool m_FireInputWasHeld;


        private PlayerControllerInput controls;

        private bool isAimPressed;
        private bool isFirePressed;
        private bool isJumpPressed;
        private bool isCrouchPressed;
        private bool isReloadPressed;
        private bool isSprintPressed;

        private bool isChangeGunNext;
        private bool isChangeGunPrevious;
        private bool isChangeGunTo1;
        private bool isChangeGunTo2;
        private bool isChangeGunTo3;

        private Vector3 playerMovementAmmount;
        private Vector2 cameraMovementAmmount;

        void Start()
        {
            m_PlayerCharacterController = GetComponent<PlayerCharacterController>();
            m_GameFlowManager = FindObjectOfType<GameFlowManager>();

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        public void OnAim(InputAction.CallbackContext ctx)
        {
            isAimPressed = ctx.action.triggered;
        }

        public void OnCrouch(InputAction.CallbackContext ctx)
        {
            isCrouchPressed = ctx.action.triggered;
        }

        public void OnChangeGunNext(InputAction.CallbackContext ctx)
        {
            isChangeGunNext = ctx.action.triggered;
        }

        public void OnChangeGunPrevious(InputAction.CallbackContext ctx)
        {
            isChangeGunPrevious = ctx.action.triggered;
        }

        public void OnChangeGunTo1(InputAction.CallbackContext ctx)
        {
            isChangeGunTo1 = ctx.action.triggered;
        }

        public void OnChangeGunTo2(InputAction.CallbackContext ctx)
        {
            isChangeGunTo2 = ctx.action.triggered;
        }

        public void OnChangeGunTo3(InputAction.CallbackContext ctx)
        {
            isChangeGunTo3 = ctx.action.triggered;
        }

        public void OnFire(InputAction.CallbackContext ctx)
        {
            isFirePressed = ctx.action.triggered;
        }

        public void OnJump(InputAction.CallbackContext ctx)
        {
            isJumpPressed = ctx.action.triggered;
        }

        public void OnMovePlayer(InputAction.CallbackContext ctx) 
        {
            var playerMovementAmmount = ctx.ReadValue<Vector2>();

            this.playerMovementAmmount = new Vector3(playerMovementAmmount.x, 0, playerMovementAmmount.y); 
        }

        public void OnMoveCamera(InputAction.CallbackContext ctx)
        {
            var cameraMovementAmmount = ctx.ReadValue<Vector2>();

            // Todo: add invert
            // isToInvert
            int invert = false ? 1 : -1;

            this.cameraMovementAmmount = new Vector2(cameraMovementAmmount.x * 0.007f, cameraMovementAmmount.y * invert * 0.005f);
        }

        public void OnMoveCameraMouseX(InputAction.CallbackContext ctx)
        {
            cameraMovementAmmount = new Vector2(ctx.ReadValue<float>() * 0.0010f, cameraMovementAmmount.y);
        }

        public void OnMoveCameraMouseY(InputAction.CallbackContext ctx)
        {
            // Todo: add invert
            // isToInvert
            cameraMovementAmmount = new Vector2(cameraMovementAmmount.x, ctx.ReadValue<float>() * -0.0010f);
        }

        public void OnReload(InputAction.CallbackContext ctx)
        {
            isReloadPressed = ctx.action.triggered;
        }

        public void OnSprint(InputAction.CallbackContext ctx)
        {
            isSprintPressed = ctx.action.triggered;
        }

        void LateUpdate()
        {
            m_FireInputWasHeld = GetFireInputHeld();
        }

        public bool CanProcessInput()
        {
            // Todo: update to new input system
            return true; //Cursor.lockState == CursorLockMode.Locked && !m_GameFlowManager.GameIsEnding;
        }

        public Vector3 GetMoveInput()
        {
            if (CanProcessInput())
            {
                Vector3 move = playerMovementAmmount;

                // constrain move input to a maximum magnitude of 1, otherwise diagonal movement might exceed the max move speed defined
                move = Vector3.ClampMagnitude(move, 1);

                return move;
            }

            return Vector3.zero;
        }

        public float GetLookInputsHorizontal()
            => cameraMovementAmmount.x;

        public float GetLookInputsVertical()
            => cameraMovementAmmount.y;

        public bool GetJumpInputDown()
        {
            if (CanProcessInput())
            {
                return isJumpPressed;
            }

            return false;
        }

        public bool GetJumpInputHeld()
        {
            if (CanProcessInput())
                return isJumpPressed;

            return false;
        }

        public bool GetFireInputDown()
        {
            return GetFireInputHeld() && !m_FireInputWasHeld;
        }

        public bool GetFireInputReleased()
        {
            return !GetFireInputHeld() && m_FireInputWasHeld;
        }

        public bool GetFireInputHeld()
        {
            if (CanProcessInput())
                return isFirePressed;

            return false;
        }

        public bool GetAimInputHeld()
        {
            if (CanProcessInput())
                return isAimPressed;

            return false;
        }

        public bool GetSprintInputHeld()
        {
            if (CanProcessInput())
            {
                // Todo:
                return isSprintPressed;
            }

            return false;
        }

        public bool GetCrouchInputDown()
        {
            if (CanProcessInput())
            {
                return isCrouchPressed;
            }

            return false;
        }

        public bool GetCrouchInputReleased()
        {
            if (CanProcessInput())
            {
                //Todo:
                return !isCrouchPressed;
            }

            return false;
        }

        public bool GetReloadButtonDown()
        {
            if (CanProcessInput())
            {
                return isReloadPressed;
            }

            return false;
        }

        public int GetSwitchWeaponInput()
        {
            if (CanProcessInput())
            {
                if (isChangeGunNext)
                    return 1;
                else if (isChangeGunPrevious)
                    return -1;
            }

            return 0;
        }

        public int GetSelectWeaponInput()
        {
            if (CanProcessInput())
            {
                if (isChangeGunTo1)
                    return 1;
                else if (isChangeGunTo2)
                    return 2;
                else if (isChangeGunTo3)
                    return 3;
                else
                    return 0;
            }

            return 0;
        }
    }
}