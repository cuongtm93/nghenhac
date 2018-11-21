import React, { Component } from 'react';
import { Footer } from './Footer';
import { Body } from './Body';
import { Header } from './Header';

export class Layout extends Component {
    render() {
        return (
            <div className='App container-fluid'>
                <Header />
                <Body>
                    {this.props.children}
                </Body>
                <Footer />
            </div>
        );
    }
}
