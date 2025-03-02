import React, {Component} from 'react';
//import './third.scss'
// import { connect } from "react-redux";
// import { bindActionCreators } from "redux";
// import * as thirdActions from "../../store/third/actions";
export default class third extends Component {
    constructor(props) {
        super(props);
        this.state = {
          firstName:"Isha",
          lastName:"Ghosh",
          Company:"Wipro"
        };
    }
    render() {
      return <div className="component-third">Details<br/>
          <p>First name: <b>{this.state.firstName} {this.state.lastName}</b></p>
          <p>Last Name: <b>{this.state.lastName}</b></p>
        <p>Company:<b> {this.state.Company}</b></p>
      
      </div>;
    }
  }
// export default connect(
//     ({ third }) => ({ ...third }),
//     dispatch => bindActionCreators({ ...thirdActions }, dispatch)
//   )( third );