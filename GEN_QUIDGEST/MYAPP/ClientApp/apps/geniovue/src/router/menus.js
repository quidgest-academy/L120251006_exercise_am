// eslint-disable-next-line @typescript-eslint/no-unused-vars
import { updateQueryParams } from './routeUtils.js'

export default function getMenusRoutes()
{
	return [
		{
			path: '/:culture/:system/RMS/menu/RMS_41',
			name: 'menu-RMS_41',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_41/QMenuRms41.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '41',
				baseArea: 'T_001',
				hasInitialPHE: false,
				humanKeyFields: ['ValEmail'],
			}
		},
		{
			path: '/:culture/:system/RMS/menu/RMS_61',
			name: 'menu-RMS_61',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_61/QMenuRms61.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '61',
				baseArea: 'T_004',
				hasInitialPHE: false,
				humanKeyFields: ['ValCity'],
			}
		},
		{
			path: '/:culture/:system/RMS/menu/RMS_21',
			name: 'menu-RMS_21',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_21/QMenuRms21.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '21',
				baseArea: 'T_002',
				hasInitialPHE: false,
				humanKeyFields: ['ValTitle'],
			}
		},
		{
			path: '/:culture/:system/RMS/menu/RMS_31',
			name: 'menu-RMS_31',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_31/QMenuRms31.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '31',
				baseArea: 'T_006',
				hasInitialPHE: false,
				humanKeyFields: ['ValDescription'],
			}
		},
		{
			path: '/:culture/:system/RMS/menu/RMS_11',
			name: 'menu-RMS_11',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_11/QMenuRms11.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '11',
				baseArea: 'T_005',
				hasInitialPHE: false,
				humanKeyFields: ['ValClientname'],
			}
		},
		{
			path: '/:culture/:system/RMS/menu/RMS_51',
			name: 'menu-RMS_51',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_51/QMenuRms51.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '51',
				baseArea: 'T_003',
				hasInitialPHE: false,
				humanKeyFields: ['ValCountry'],
			}
		},
	]
}
