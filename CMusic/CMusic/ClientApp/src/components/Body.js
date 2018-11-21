import React, { Component } from 'react';

export class Body extends Component {
  displayName = Body.name;
  constructor(props) {
    super(props);
  }
  render() {
    return (
        <div className="content row">
            {this.props.children}
     </div>
    );
  }
}
