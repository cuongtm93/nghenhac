import React, { Component } from 'react';
import { NavMenuItem } from './NavMenuItem'

export class NavMenu extends Component {
    displayName = NavMenu.name

    render() {
        return (
            <div className='nav row'>
                <div className="col-md-12">
                    <NavMenuItem text='Trang chủ' route='/home' />
                    <NavMenuItem text='Tìm kiếm' route='/search' />
                    <NavMenuItem text='Cường' route='/home' />
                    <NavMenuItem text='Cường' route='/home' />
                    <NavMenuItem text='Cường' route='/home'  />
                </div>
            </div>
        );
    }
}
