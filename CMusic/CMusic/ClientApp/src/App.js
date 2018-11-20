import React, { Component } from 'react';
import { Home } from './components/Body';
import { NavMenu } from './components/NavMenu';

export default class App extends Component {
    displayName = App.name;
    render() {
        return (
            <div className='App'>
                <NavMenu />
                <Home />
            </div>
        );
    }
}
