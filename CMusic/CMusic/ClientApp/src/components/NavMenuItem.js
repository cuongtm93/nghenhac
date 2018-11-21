import React, { Component } from 'react';
import { Link, Router, Route } from 'react-router-dom';

export class NavMenuItem extends Component {
    displayName = NavMenuItem.name
    
    render() {
        return (
            <Link to={this.props.route}  >
            <div className='nav__menu_item'>
                
                    {this.props.text}
               
                </div>
            </Link>
        );
    }
}
