import React from "react";

// StateComponent: Manages the login form
class StateComponent extends React.Component {
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

  // Handles input field changes
  handleInputChange(event) {
    this.setState({ [event.target.name]: event.target.value });
  }

  // Handles login button click
  handleLogin() {
    console.log("Username:", this.state.username);
    console.log("Password:", this.state.password);
    this.setState({ isLoggedIn: true });
  }

  render() {
    return (
      <div>
        {!this.state.isLoggedIn ? (
          <div>
            <h2>Login Page</h2>
            <input
              type="text"
              name="username"
              placeholder="Enter Username"
              onChange={this.handleInputChange}
            />
            <br />
            <input
              type="password"
              name="password"
              placeholder="Enter Password"
              onChange={this.handleInputChange}
            />
            <br />
            <button onClick={this.handleLogin}>Login</button>
          </div>
        ) : (
            <div>
        <h2>Login Successful!</h2> <h4> Welcome,{this.state.username}!</h4>
        {/* <h2>Password: {this.state.password}</h2> */}
      </div>
            )}
      </div>
    );
  }
}



export default StateComponent;
