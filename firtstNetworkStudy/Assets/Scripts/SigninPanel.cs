using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SigninPanel : MonoBehaviour
{
    [SerializeField] private TMP_InputField _emailInput;
    [SerializeField] private TMP_InputField _passwordInput;
    [SerializeField] private Button _signInButton;
    [SerializeField] private Button _signUpButton;
    [SerializeField] private Button _deleteButton;

    private void OnEnable()
    {
        BindButtons();
    }

    private void OnDisable()
    {
        UnBindButtons();
    }

    private void BindButtons()
    {
        _signUpButton.onClick.AddListener(SignUp);
        _signInButton.onClick.AddListener(SignIn);
        _deleteButton.onClick.AddListener(Delete);
    }

    private void UnBindButtons()
    {
        _signInButton.onClick.RemoveListener(SignUp);
        _signUpButton.onClick.RemoveListener(SignIn);
        _deleteButton.onClick.RemoveListener(Delete);
    }
    
    private void SignUp()
    {
        BackendManager.Instance.SignUp(_emailInput.text, _passwordInput.text);
    }

    private void SignIn()
    {
        BackendManager.Instance.SignIn(_emailInput.text, _passwordInput.text);
    }

    private void Delete()
    {
        BackendManager.Instance.DeleteUser();
    }
}
