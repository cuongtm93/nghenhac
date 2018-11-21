import React, { Component } from 'react';
import { SearchBar } from './components/SearchBar';

export class SearchPage extends Component {
    render() {
        return (
            <div>
                <SearchBar />
                <SearchBar />
            </div>
        );
    }
}
