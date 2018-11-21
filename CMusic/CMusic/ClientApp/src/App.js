import React, { Component } from 'react';

import { NavMenu } from './components/NavMenu';
import { Route } from 'react-router';

import { Layout } from './components/Layout';
import './App.css';
import { HomePage } from './HomePage';
import { SearchPage } from './SearchPage';

export default class App extends Component {
    displayName = App.name;
    render() {
        return (
            <Layout>
                <Route exact path='/' component={HomePage} />
                <Route path='/home' component={HomePage} />
                <Route path='/search' component={SearchPage} />
            </Layout>
        );
    }
}
