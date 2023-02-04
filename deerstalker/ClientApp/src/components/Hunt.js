import React, { Component } from 'react';

export class Hunt extends Component {
  static displayName = Hunt.name;
  
  constructor() {
    super();
    this.shotSomething = this.shotSomething.bind(this);
  }

  shotSomething() {
    // this is where we write to the database.
  }

  render() {
    return (
      <div>
        <button className="btn btn-primary" onClick={this.shotSomething}>I shot something</button>
      </div>
    );
  }
}
