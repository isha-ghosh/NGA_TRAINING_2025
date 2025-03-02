import React, {Component} from 'react';
//import './buttex.scss'
// import { connect } from "react-redux";
// import { bindActionCreators } from "redux";
// import * as buttexActions from "../../store/buttex/actions";
export default class buttex extends Component {
    // constructor(props) {
    //     super(props);
    //     this.state = {};
    // }
    isha=()=>{
      alert("i am isha");
    }
    render() {
      return <div className="component-buttex">
        <input type='button' value="Isha" onClick={this.isha}>
        </input>
        

      </div>;
    }
  }
// export default connect(
//     ({ buttex }) => ({ ...buttex }),
//     dispatch => bindActionCreators({ ...buttexActions }, dispatch)
//   )( buttex );