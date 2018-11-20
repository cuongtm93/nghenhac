import React, { Component } from 'react';
import { Home } from './components/Home';
import { NavMenu } from './components/NavMenu';

export default class App extends Component {
    displayName = App.name

    render() {
        return (
            <NavMenu />
        );
    }
}
