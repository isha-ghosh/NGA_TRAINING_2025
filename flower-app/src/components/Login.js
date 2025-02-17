import React from "react";


class Login extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      username: "",
      password: "",
      isLoggedIn: false,
    };
    this.handleInputChange = this.handleInputChange.bind(this);
    this.handleLogin = this.handleLogin.bind(this);
  }

 
  handleInputChange(event) {
    this.setState({ [event.target.name]: event.target.value });
  }

 
  handleLogin() {
    console.log("Username:", this.state.username);
    console.log("Password:", this.state.password);
    this.setState({ isLoggedIn: true });
  }

  render() {
    return (
      <div>
        {!this.state.isLoggedIn ? (
          <div className="login-about">
            <h2>Login Page</h2>
            <input
              type="text"
              name="username"
              placeholder="Enter Username"
              onChange={this.handleInputChange}
            />
            <br />
            <br/>
            <input
              type="password"
              name="password"
              placeholder="Enter Password"
              onChange={this.handleInputChange}
            />
            <br/>
            <br />
            <button  className="login-button" onClick={this.handleLogin}>Login</button>
          </div>
        ) : (
            <div className="login-about">
        <h2>Login Successful!</h2> <h4> Welcome,{this.state.username}!</h4>
        {/* <h2>Password: {this.state.password}</h2> */}
      </div>
            )}
      </div>
    );
  }
}



export default Login;
