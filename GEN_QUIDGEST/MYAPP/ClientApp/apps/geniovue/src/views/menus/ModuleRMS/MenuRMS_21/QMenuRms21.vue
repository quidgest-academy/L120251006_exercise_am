<template>
	<teleport
		v-if="menuModalIsReady"
		:to="`#${uiContainersId.body}`"
		:disabled="!menuInfo.isPopup">
		<form
			class="form-horizontal"
			@submit.prevent>
			<q-row-container>
				<q-table
					v-bind="controls.menu"
					v-on="controls.menu.handlers">
				</q-table>

				<q-table-extra-extension
					:list-ctrl="controls.menu"
					:filter-operators="controls.menu.filterOperators"
					v-on="controls.menu.handlers" />
			</q-row-container>
		</form>
	</teleport>

	<teleport
		v-if="menuModalIsReady && hasButtons"
		:to="`#${uiContainersId.footer}`"
		:disabled="!menuInfo.isPopup">
		<q-row-container>
			<div id="footer-action-btns">
				<template
					v-for="btn in menuButtons"
					:key="btn.id">
					<q-button
						v-if="btn.isVisible"
						:id="btn.id"
						:label="btn.text"
						:variant="btn.variant"
						:disabled="btn.disabled"
						:icon-pos="btn.iconPos"
						:class="btn.classes"
						@click="btn.action">
						<q-icon
							v-if="btn.icon"
							v-bind="btn.icon" />
					</q-button>
				</template>
			</div>
		</q-row-container>
	</teleport>
</template>

<script>
	/* eslint-disable @typescript-eslint/no-unused-vars */
	import asyncProcM from '@quidgest/clientapp/composables/async'
	import qEnums from '@quidgest/clientapp/constants/enums'
	import netAPI from '@quidgest/clientapp/network'
	import openQSign from '@quidgest/clientapp/plugins/qSign'
	import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
	import { computed, readonly } from 'vue'

	import MenuHandlers from '@/mixins/menuHandlers.js'
	import controlClass from '@/mixins/fieldControl.js'
	import listFunctions from '@/mixins/listFunctions.js'
	import listColumnTypes from '@/mixins/listColumnTypes.js'
	import { resetProgressBar, setProgressBar } from '@/utils/layout.js'

	import { loadResources } from '@/plugins/i18n.js'

	import hardcodedTexts from '@/hardcodedTexts'
	import qApi from '@/api/genio/quidgestFunctions.js'
	import qFunctions from '@/api/genio/projectFunctions.js'
	import qProjArrays from '@/api/genio/projectArrays.js'
	/* eslint-enable @typescript-eslint/no-unused-vars */

	import MenuViewModel from './QMenuRMS_21ViewModel.js'

	const requiredTextResources = ['QMenuRMS_21', 'hardcoded', 'messages']

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS FORM_INCLUDEJS RMS_MENU_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

	export default {
		name: 'QMenuRms21',

		mixins: [
			MenuHandlers
		],

		inheritAttrs: false,

		props: {
			/**
			 * Whether or not the menu is used as a homepage.
			 */
			isHomePage: {
				type: Boolean,
				default: false
			}
		},

		expose: [
			'navigationId',
			'onBeforeRouteLeave',
			'updateMenuNavigation'
		],

		data()
		{
			// eslint-disable-next-line
			const vm = this
			return {
				componentOnLoadProc: asyncProcM.getProcListMonitor('QMenuRMS_21', false),

				interfaceMetadata: {
					id: 'QMenuRMS_21', // Used for resources
					requiredTextResources
				},

				menuInfo: {
					id: '21',
					isMenuList: true,
					designation: computed(() => this.Resources.USER_PROFILES41435),
					acronym: 'RMS_21',
					name: 'U_PRF',
					route: 'menu-RMS_21',
					order: '21',
					controller: 'U_PRF',
					action: 'RMS_Menu_21',
					isPopup: false
				},

				model: new MenuViewModel(this),

				controls: {
					menu: new controlClass.TableListControl({
						fnHydrateViewModel: (data) => vm.model.hydrate(data),
						id: 'RMS_Menu_21',
						controller: 'U_PRF',
						action: 'RMS_Menu_21',
						hasDependencies: false,
						isInCollapsible: false,
						tableModeClasses: [
							'q-table--full-height',
							'page-full-height'
						],
						columnsOriginal: [
							new listColumnTypes.ImageColumn({
								order: 1,
								name: 'ValU_img',
								area: 'U_PRF',
								field: 'U_IMG',
								label: computed(() => this.Resources.USER_IMAGE40060),
								dataTitle: computed(() => genericFunctions.formatString(vm.Resources.IMAGEM_UTILIZADA_PAR58591, vm.Resources.USER_IMAGE40060)),
								scrollData: 3,
								sortable: false,
								searchable: false,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.TextColumn({
								order: 2,
								name: 'ValU_email',
								area: 'U_PRF',
								field: 'U_EMAIL',
								label: computed(() => this.Resources.EMAIL25170),
								dataLength: 50,
								scrollData: 30,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.TextColumn({
								order: 3,
								name: 'ValUsername',
								area: 'U_PRF',
								field: 'USERNAME',
								label: computed(() => this.Resources.USERNAME51409),
								dataLength: 12,
								scrollData: 12,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.DateColumn({
								order: 4,
								name: 'ValBday',
								area: 'U_PRF',
								field: 'BDAY',
								label: computed(() => this.Resources.DATE_OF_BIRTH36542),
								scrollData: 8,
								dateTimeType: 'date',
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
						],
						config: {
							name: 'RMS_Menu_21',
							serverMode: true,
							pkColumn: 'ValCodu_prf',
							tableAlias: 'U_PRF',
							tableNamePlural: computed(() => this.Resources.USER_PROFILES41435),
							viewManagement: '',
							showLimitsInfo: true,
							tableTitle: computed(() => this.Resources.USER_PROFILES41435),
							showAlternatePagination: true,
							permissions: {
							},
							searchBarConfig: {
								visibility: true,
								searchOnPressEnter: true
							},
							filtersVisible: true,
							allowColumnFilters: true,
							allowColumnSort: true,
							crudActions: [
								{
									id: 'show',
									name: 'show',
									title: computed(() => this.Resources.CONSULTAR57388),
									icon: {
										icon: 'view'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_001',
										mode: 'SHOW',
										isControlled: true
									}
								},
								{
									id: 'edit',
									name: 'edit',
									title: computed(() => this.Resources.EDITAR11616),
									icon: {
										icon: 'pencil'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_001',
										mode: 'EDIT',
										isControlled: true
									}
								},
								{
									id: 'duplicate',
									name: 'duplicate',
									title: computed(() => this.Resources.DUPLICAR09748),
									icon: {
										icon: 'duplicate'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_001',
										mode: 'DUPLICATE',
										isControlled: true
									}
								},
								{
									id: 'delete',
									name: 'delete',
									title: computed(() => this.Resources.ELIMINAR21155),
									icon: {
										icon: 'delete'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_001',
										mode: 'DELETE',
										isControlled: true
									}
								}
							],
							generalActions: [
								{
									id: 'insert',
									name: 'insert',
									title: computed(() => this.Resources.INSERIR43365),
									icon: {
										icon: 'add'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_001',
										mode: 'NEW',
										repeatInsertion: false,
										isControlled: true
									}
								},
							],
							generalCustomActions: [
							],
							groupActions: [
							],
							customActions: [
							],
							MCActions: [
							],
							rowClickAction: {
								id: 'RCA_RMS_211',
								name: 'form-F_001',
								params: {
									isRoute: true,
									limits: [
										{
											identifier: 'id',
											fnValueSelector: (row) => row.ValCodu_prf
										},
									],
									isControlled: true,
									action: vm.openFormAction, type: 'form', mode: 'SHOW', formName: 'F_001'
								}
							},
							formsDefinition: {
								'F_001': {
									fnKeySelector: (row) => row.Fields.ValCodu_prf,
									isPopup: false
								},
							},
							defaultSearchColumnName: 'ValUsername',
							defaultSearchColumnNameOriginal: 'ValUsername',
							defaultColumnSorting: {
								columnName: 'ValU_email',
								sortOrder: 'asc'
							}
						},
						globalEvents: ['changed-U_PRF'],
						uuid: '8eaaf3fd-5c5f-4c37-b799-d847da1371bc',
						allSelectedRows: 'false',
						headerLevel: 1,
					}, this),
				}
			}
		},

		beforeRouteEnter(to, _, next)
		{
			// called before the route that renders this component is confirmed.
			// does NOT have access to `this` component instance,
			// because it has not been created yet when this guard is called!

			next((vm) => vm.updateMenuNavigation(to))
		},

		beforeRouteLeave(to, _, next)
		{
			this.onBeforeRouteLeave(next)
		},

		mounted()
		{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS FORM_CODEJS RMS_MENU_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		},

		beforeUnmount()
		{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS COMPONENT_BEFORE_UNMOUNT RMS_MENU_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		},

		methods: {
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS FUNCTIONS_JS RMS_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS LISTING_CODEJS RMS_MENU_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		}
	}
</script>
